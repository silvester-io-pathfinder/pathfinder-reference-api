using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Innovations.Instances
{
    public class Armor : Template
    {
        public static readonly Guid ID = Guid.Parse("a632fad7-ca25-4709-8469-a912656e6a73");

        protected override Innovation GetInnovation()
        {
            return new Innovation
            {
                Id = ID,
                Name = "Armor Innovation",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("822b4a9b-cb1d-41cd-8cc8-0a634c790666"), Type = TextBlockType.Text, Text = "Your innovation is a cutting-edge suit of medium armor with a variety of attached gizmos and devices. Choose one of the sets of statistics on Table 2�2: Innovation Armor Statistics for your innovation armor (or choose another set of innovation armor statistics to which you have access)." };
            yield return new TextBlock { Id = Guid.Parse("591cbf1b-4b61-4694-86a0-7863abf8b1ad"), Type = TextBlockType.Text, Text = "Your innovation armor can have fundamental and property runes added to it in the same way as ordinary armor. Because of the unique features of your innovation, everyone except you is untrained in it, even if they would normally be trained (or better) in medium armor." };
            yield return new TextBlock { Id = Guid.Parse("4e64d4bf-263d-4995-92f1-0b66c5bba776"), Type = TextBlockType.Text, Text = "Choose one initial armor modification to apply to your innovation, either from the following or from other initial armor modifications to which you have access." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("6668f0bc-4eb0-439e-81f7-4207da266db2"), or => 
            {
                or.GainSpecificArmor(Guid.Parse("0320f580-23ca-4a56-8ccb-494c8d106c68"), Armors.Instances.PowerSuit.ID);
                or.GainSpecificArmor(Guid.Parse("909e7896-20a8-43f2-ac48-906b137ce10b"), Armors.Instances.SubterfugeSuit.ID);
            });

            builder.GainAnyInnovationModification(Guid.Parse("aa574907-b71e-499e-8c63-c420cb1e84a3"), InnovationModificationTypes.Instances.Initial.ID);
        }

        protected override Table GetTable()
        {
            return new TableBuilder()
                .AddColumn("980cd4d2-208c-4a4d-a4f1-cf212fd9e534", "Medium Armor")
                .AddColumn("9014c916-857f-4989-a39a-8f5bf77a17f2", "AC Bonus")
                .AddColumn("9c8b22f6-7d07-4b16-8f69-f68f312a610c", "Dex Cap")
                .AddColumn("a58fb073-a9ef-41b1-ad01-8d947b33cba8", "Check Penalty")
                .AddColumn("9190bf91-70d5-41a2-9856-4883df4f7987", "Speed Penalty")
                .AddColumn("501ff5db-313c-454d-9ca4-576f6e11f88d", "Strength")
                .AddColumn("0910face-2676-4d72-85f4-857761105200", "Bulk")
                .AddColumn("233b23f1-20bf-4bf5-a79e-17c2f78c450c", "Group")
                .AddColumn("da818692-b8f7-48ef-be2f-04cf0abedc24", "Armor Traits")
                .AddRow("4c35cbed-75a5-4ff1-b73d-5e8715156c92", row =>
                {
                    row
                        .AddCell("36f6c174-d7f4-4eae-9090-f86a8699fe9e", "Power Suit")
                        .AddCell("f245fc3c-e007-4054-a3c0-4681557ff6e6", "+4")
                        .AddCell("d93ef17e-4929-463f-963a-f4b2b36c83c5", "+1")
                        .AddCell("eb348495-c2c3-42c5-a0b0-5a481d2958dc", "-2")
                        .AddCell("09319654-3436-47e2-ac26-7fac7e0960f2", "-5 feet")
                        .AddCell("ab1d168a-15a1-4935-aa14-eedec8db951a", "16")
                        .AddCell("40f0f594-7755-4535-87cd-59cb7570e0ac", "2")
                        .AddCell("d542121c-7bb7-4dc3-a90c-45503232e232", "composite")
                        .AddCell("af31eb57-fed6-435b-bb1d-4133c8f3b0c2", "-");
                })
                .AddRow("46f346e0-6785-4071-878f-32c7285cfe72", row =>
                {
                    row
                        .AddCell("b2a078f8-d0c9-4033-9a9a-46ac32ccc0da", "Subterfuge Suit")
                        .AddCell("51a43288-f104-4f5b-9816-eefd0373ba49", "+1")
                        .AddCell("7c919fb1-9932-44ae-b59e-48ba2c77b76f", "+4")
                        .AddCell("c5f63fae-ddcd-4cda-b403-16373ec1e20c", "-1")
                        .AddCell("462792fa-42f8-4d3f-aeee-237ef4148e51", "-")
                        .AddCell("4802fe43-d8b4-4bd6-bc1a-d3fdd56402fd", "10")
                        .AddCell("428b6f19-4cf8-4f89-8556-f148c41d0ae2", "1")
                        .AddCell("b303a398-5189-4384-bdc6-654b94d8c172", "composite")
                        .AddCell("4855a471-aba7-4b09-8545-7f7528fc98ce", "-");
                })
                .Build("06accbef-0ad7-4c29-9d2a-464bb4e93833");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("602a790f-246a-42bb-95a8-d1ce0bb21a35"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 16
            };
        }
    }
}
