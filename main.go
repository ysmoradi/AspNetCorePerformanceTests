package main



import (

	"github.com/kataras/iris"

	"github.com/kataras/iris/context"

)



func main() {

	app := iris.New()

	app.Get("/api/values/{id}", func(ctx context.Context) {

		ctx.WriteString(ctx.Params().Get("id"))

	})

	app.Run(iris.Addr(":5000"), iris.WithoutVersionChecker)

}