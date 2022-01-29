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
    public class TrapsmithDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("84bed3f8-a3ff-44b1-935a-65c8670ea014");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Trapsmith Dedication",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the snarecrafter or trapsmith archetypes.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("225d6850-76c9-4ac7-b571-fa403baca7b2"), Type = TextBlockType.Text, Text = $"You use glimmering gears and gnashing mechanisms to manufacture snares using specialized parts. Your snares include clockwork and steam-powered cogwheels and gears, and their gush of steam can hinder those you ensnare. If you choose to construct a snare using gears and a creature fails their saving throw against the snare, all creatures are concealed to that creature for 1 round, as a burst of steam obscures its vision." };
            yield return new TextBlock { Id = Guid.Parse("fe96a184-28cf-4f73-a4c5-fcd3b47fbb44"), Type = TextBlockType.Text, Text = $"__You can select this dedication feat for the trapsmith archetype even if you haven't yet gained three feats from the snarecrafter archetype.__" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("29a3f0ff-a489-47ab-b306-fc65989e30c4"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("c4834fea-0035-49d0-923c-1c1089b0b896"), Feats.Instances.SnarecrafterDedication.ID);
                or.HaveSpecificFeat(Guid.Parse("0cf5a472-f80e-4068-984b-abeb04a273b5"), Feats.Instances.SnareSpecialist.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f522d89-e74f-4bee-890e-c3308a654be4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
