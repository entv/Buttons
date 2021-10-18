using System;
using Buttons.Core.Exceptions;
using Buttons.Core.Services;
using Buttons.Core.Views;

namespace Buttons.Core.Controllers
{
    public abstract class BaseController
    {
        protected IView _view;
        protected IEntityService _entityService;

        public BaseController(IView view, IEntityService entityService)
        {
            _view = view;
            _entityService = entityService;
        }

        public void Start()
        {
            _view.OnButtonClick += HandleQuery;
        }

        public void Stop()
        {
            _view.OnButtonClick -= HandleQuery;
        }

        public abstract void HandleQuery(string query);
    }

    public class ApplicationController : BaseController
    {
        public ApplicationController(IView view, IEntityService entityService) : base(view, entityService)
        {

        }

        public override void HandleQuery(string query)
        {
            _view.Text = GetTextByQuery(query);
        }

        private string GetTextByQuery(string query)
        {
            try
            {
                var entity = _entityService.GetByQuery(query);

                return entity.Text;
            }
            catch(BadQueryException exception)
            {
                return exception.Message;
            }
            catch(ElementDoesNotExistException exception)
            {
                return exception.Message;
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
    }
}
