using Constructs;
using HashiCorp.Cdktf;
using HashiCorp.Cdktf.Providers.Azurerm;
using VFrameworkBlazor.Utility;

namespace VFrameworkBlazor.Terraform
{
    public class DefaultTFTemplate : TerraformStack
    {
        internal DefaultTFTemplate(Construct scope, string id) : base(scope, id)
        {
            new AzurermProvider(this, "AzureRm", new AzurermProviderConfig
            {
                Features = new AzurermProviderFeatures(),
                TenantId = "kek"
            });

            new VirtualNetwork(this, "TfVnet", new VirtualNetworkConfig
            {
                Location = "westeuroe",
                AddressSpace = new[] { "10.0.0.0/24" },
                Name = "TerraformVNet",
                ResourceGroupName = "RGtest"
            });
        }

        internal static void Init()
        {
            HashiCorp.Cdktf.App app = new();
            new DefaultTFTemplate(app, "azure");
            app.Synth();
        }
    }
}
