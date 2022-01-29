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
    public class BeastmasterBond : Template
    {
        public static readonly Guid ID = Guid.Parse("4f2d8fac-2378-4b7b-aa44-a10fa910b265");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Beastmaster Bond",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5bb5643e-40c1-4e79-b972-3c67e389620f"), Type = TextBlockType.Text, Text = $"You can communicate telepathically with your animal companions within 100 feet. If you're legendary in Nature, you can communicate telepathically with your animal companions anywhere on the planet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ec8aad6d-376c-42c6-8850-1f496e5b8544"), Feats.Instances.BeastmasterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("05955e2a-6cdc-47ad-b20f-b4eb4f06988d"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("4c15e5b4-822d-47e0-bc36-80c5fe5a91e8"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("57cf6ab8-7919-4d54-b439-0611c07fae44"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("ac2dee9d-ab86-474f-b08d-495d1749a379"), Traits.Instances.Primal.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("007f00f7-1327-4a25-8370-a7902f191ee2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
