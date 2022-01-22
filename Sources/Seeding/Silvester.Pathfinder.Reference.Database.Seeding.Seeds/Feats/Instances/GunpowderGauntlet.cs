using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GunpowderGauntlet : Template
    {
        public static readonly Guid ID = Guid.Parse("11fc8eec-e58e-483d-93e6-12b1adf5239c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gunpowder Gauntlet",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e85826ba-a8f0-4956-848f-a81cea4ff646"), Type = TextBlockType.Text, Text = $"Your flair keeps foes' attention, as your motions with your gun draw your foes into a deadly game. As you toy with them and performatively brandish your weapon, you build their tunnel vision, leaving them trapped in a perceptual gauntlet of your own making. Attempt a Performance check against the Will DC of a single target within your one-handed firearm's first range increment." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("635b8faf-f9ec-458f-9ce9-e84fce850e24"), Feats.Instances.PistolPhenomDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("dd910c30-d812-425c-b446-d09ea85ec676"),
                CriticalSuccess = "The target takes a –2 status penalty to attack rolls against creatures other than you until the beginning of your next turn.",
                Success = "The target takes a –1 status penalty to attack rolls against creatures other than you until the beginning of your next turn.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef170152-3152-42d7-8d57-0b86d21bb60b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
