using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Constructs;
using HashiCorp.Cdktf;
using HashiCorp.Cdktf.Providers.Azurerm;

namespace VFrameworkBlazor.Terraform
{
    public class TfLogic : TerraformStack
    {
        public TfLogic(Construct scope, string id) : base(scope, id)
        {
            new AzurermProvider(this, "AzureRm", new AzurermProviderConfig
            {
                Features = new AzurermProviderFeatures()
            });

            new VirtualNetwork(this, "TfVnet", new VirtualNetworkConfig
            {
                Location = "westeurope",
                AddressSpace = new [] {"10.0.0.0/24"},
                Name = "TerraformVNet",
                ResourceGroupName = "RGtest"
            });
        }

        public static void Init()
        {
            HashiCorp.Cdktf.App app = new();
            new TfLogic(app, "azure");
            app.Synth(); 
        }
    }
}
