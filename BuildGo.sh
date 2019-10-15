#/bin/bash
find . -iname '*.proto' | sed -n 's/\.\/Source\/\([A-Z][^\/]*\)\/.*/\1/gp' | uniq | while read project; do
    mkdir -p "Source/$project.Go"
    protofiles=$(find "Source/$project" -iname '*.proto')
    protoc "-ISource/" "--go_out=plugins=grpc:Source/$project.Go" $protofiles
done
