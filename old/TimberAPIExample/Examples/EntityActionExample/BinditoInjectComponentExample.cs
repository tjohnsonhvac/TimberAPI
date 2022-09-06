using System;

namespace TimberAPIExample.Examples.EntityActionExample
{
    public class BinditoInjectComponentExample : MonoBehaviour
    {
        private ILoc _loc;
        
        [Inject]
        public void InjectDependencies(ILoc loc)
        {
            _loc = loc;
        }

        private void Start()
        {
            Console.WriteLine(_loc.T("preview.bindito.start"));
        }
    }
}