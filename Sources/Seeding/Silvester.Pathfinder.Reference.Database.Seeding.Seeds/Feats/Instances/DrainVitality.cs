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
    public class DrainVitality : Template
    {
        public static readonly Guid ID = Guid.Parse("20ddfb53-0fb5-4d8b-bb4e-62bb06da9d54");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Drain Vitality",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e5d3cad0-7848-4cfb-a64e-8e59d7249ab4"), Type = TextBlockType.Text, Text = $"You draw out the bestial magic energy within your bonded beast gun to fortify yourself, purge ongoing harm, and bolster your life force with a sheath of swirling life essence. You gain temporary Hit Points equal to your level and attempt a flat check against any ongoing persistent damage, using the DC appropriate for particularly effective assistance. Using this ability depletes the magic within your bonded beast gun, preventing you from using any of its activated abilities until the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dd6c9bcf-bca3-4ec9-9f91-f6410b98d9d0"), Feats.Instances.BeastGunnerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d5350f12-dc70-4c5d-83ae-16497244a57d"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("42bc4c3c-abe7-4ab0-8a4f-9d41d9f54355"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("a32badcb-98ad-4ae6-8dc6-b5ca6fbefa38"), Traits.Instances.Necromancy.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("760cc814-b1b7-406c-801f-c025e38b44e0"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
