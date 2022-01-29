using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickenedCasting : Template
    {
        public static readonly Guid ID = Guid.Parse("1280d9ed-e2e3-40b6-b2c4-442cd09079fd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quickened Casting",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9d2ca375-49ce-4d9b-88dc-fdd8be00ae30"), Type = TextBlockType.Text, Text = $"In a mentally strenuous process, you modify your casting of a spell to take less time. If your next action is to cast a witch cantrip or a spell that is at least 2 levels lower than the highest-level witch spell slot you have, reduce the number of actions to cast it by 1 (minimum 1 action)." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("bfdcff44-bb1b-47ba-a137-43c41b13402b"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("b58c86f1-d6d3-4788-9b40-36f38fe988ab"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("76b8ba0c-0f3a-41c5-b56b-51847a146cf7"), Traits.Instances.Metamagic.ID);
            builder.Add(Guid.Parse("6756f3f9-d91b-4a2c-b1c8-4532685aef0b"), Traits.Instances.Oracle.ID);
            builder.Add(Guid.Parse("f1c91465-b51a-4d63-8a58-77c1c4191aa6"), Traits.Instances.Sorcerer.ID);
            builder.Add(Guid.Parse("06d3fb46-5c47-4513-9dc1-2189b1b011b4"), Traits.Instances.Witch.ID);
            builder.Add(Guid.Parse("19eab6d5-ac51-4c32-a986-15feb5e9d86e"), Traits.Instances.Wizard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1a356cbf-f817-4565-af9e-fab6b52a4c3f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
