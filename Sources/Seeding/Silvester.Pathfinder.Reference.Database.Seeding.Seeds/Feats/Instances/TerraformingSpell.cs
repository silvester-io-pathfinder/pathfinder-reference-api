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
    public class TerraformingSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("a7d4be42-e724-4965-8cc2-fab151e28ead");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Terraforming Spell",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aab214db-2ad8-4681-86fd-8858708c63cf"), Type = TextBlockType.Text, Text = $"You capture transformative fragments of magic and slam them into the ground, creating a shock wave that alters your surroundings. If your next action is to Cast a non-cantrip {ToMarkdownLink<Models.Entities.Trait>("transmutation", Traits.Instances.Transmutation.ID)} Spell, either each space adjacent to you becomes difficult terrain, or each space adjacent to you is no longer difficult terrain. This doesn't have any effect on greater difficult terrain and doesn't remove the damaging effects of hazardous terrain." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("60013c59-780a-45a0-b818-2efc940ac441"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("54edfad8-e150-4adf-a28b-8448c98be5c4"), Traits.Instances.Earth.ID);
            builder.Add(Guid.Parse("c833e753-0388-4c20-bc0a-9fe00d90da30"), Traits.Instances.Metamagic.ID);
            builder.Add(Guid.Parse("e5f9e86d-2495-4ea9-8467-7965b69a6b67"), Traits.Instances.Sorcerer.ID);
            builder.Add(Guid.Parse("95e098ec-c397-4244-9ec7-3971854ef73b"), Traits.Instances.Transmutation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ab02c9d-72b3-40ca-965f-8c1a8c5f5b82"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
