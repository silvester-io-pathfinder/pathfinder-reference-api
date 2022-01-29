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
    public class FusedPolearm : Template
    {
        public static readonly Guid ID = Guid.Parse("afb21079-a14f-4fe3-af9a-55a802fecaa5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fused Polearm",
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
            yield return new TextBlock { Id = Guid.Parse("0032f4f8-c668-451e-b493-e33b2106f56e"), Type = TextBlockType.Text, Text = $"During your daily preparations, you can magically fuse your arcane bonded weapon and a magical staff together into one item, with the staff making up the haft of the weapon. You prepare the staff at the same time you do this, and you can do this only with a staff you're able to prepare. This fusion lasts until the next time you make your daily preparations." };
            yield return new TextBlock { Id = Guid.Parse("5a30657d-1200-4c0c-b049-50d1369479e6"), Type = TextBlockType.Text, Text = $"While the two are fused, the weapon's haft takes on aesthetic aspects of the staff." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6d525c54-ad99-4a12-a47d-d3c2d83c3b9c"), Feats.Instances.RunelordDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("7a65186c-61a6-40bd-a9b2-04b0c2263049"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ae51dd5-c93e-4af7-8fa6-d65447fe6355"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
