using Nancy;
using Nancy.ModelBinding;
using Nancy.Validation;

namespace WebApplication1
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = p => "Hello World";
            Post["/"] = p => PostStuff();
        }

        private dynamic PostStuff()
        {
            var model = this.Bind<PostCommand>();
            var validationResult = this.Validate(model);

            return HttpStatusCode.Created;
        }
    }
}