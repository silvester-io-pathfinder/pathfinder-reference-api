using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrapsmithDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("a59d8214-ace5-4711-b9b7-af9de15db67e");

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
            yield return new TextBlock { Id = Guid.Parse("2f8c6f49-2957-497e-a1ea-ae1e450d21eb"), Type = TextBlockType.Text, Text = "You use glimmering gears and gnashing mechanisms to manufacture snares using specialized parts. Your snares include clockwork and steam-powered cogwheels and gears, and their gush of steam can hinder those you ensnare. If you choose to construct a snare using gears and a creature fails their saving throw against the snare, all creatures are concealed to that creature for 1 round, as a burst of steam obscures its vision." };
            yield return new TextBlock { Id = Guid.Parse("560c5f38-ee31-458e-ba1e-00aa23f5fa70"), Type = TextBlockType.Text, Text = "__You can select this dedication feat for the trapsmith archetype even if you haven’t yet gained three feats from the snarecrafter archetype.__" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("73083bfb-522f-4684-a92b-03b1b16cbc92"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("85a95745-dc1b-471e-9aee-80b372698bf6"), Feats.Instances.SnarecrafterDedication.ID);
                or.HaveSpecificFeat(Guid.Parse("294d9d0b-d5bf-4215-9be8-7b2132424387"), Feats.Instances.SnareSpecialist.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3cfe6796-fdc5-40ec-b15f-6738e853f00d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
