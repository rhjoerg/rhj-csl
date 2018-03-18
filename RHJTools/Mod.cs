using ICities;
using UnityEngine;

namespace RHJTools
{
    public class Mod : IUserMod
    {
        public string Name => "RHJ Tools";

        public string Description => "Tools for Developers";

        public void OnSettingsUI(UIHelperBase helper)
        {
            Options options = Options.instance;
            UIHelperBase group = helper.AddGroup("RHJ Tools");

            group.AddCheckbox("My Checkbox", options.MyCheck, (value) => { options.MyCheck = value; });
        }
    }
}
