using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ParthenogenicHatchling : Template
    {
        public static readonly Guid ID = Guid.Parse("a1106784-1afd-4a1c-98ab-4e24621f4069");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Parthenogenic Hatchling",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can take this feat only at 1st level.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("78b270bd-8a5e-414d-a0c0-289a8372e075"), Type = TextBlockType.Text, Text = "You were hatched from an unfertilized egg during hard times for your people, and you are a biological copy of your mother. You gain a +1 circumstance bonus to saving throws against diseases. Each of your successful saving throws against a disease reduces its stage by 2, or by 1 for a virulent disease. Each critical success against an ongoing disease reduces its stage by 3, or by 2 for a virulent disease. You take damage only every 2 hours from thirst and every 2 days from starvation, rather than every hour and every day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("321a04c1-0c2d-468a-a5d6-c5f932cd041f"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
