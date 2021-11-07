using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BasicBeastGunnerSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("43daa544-26a6-48e9-9b72-1e56043cc97e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Basic Beast Gunner Spellcasting",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c896e964-6dfb-400c-bd6b-dca3ba36657f"), Type = TextBlockType.Text, Text = "You’ve unlocked the first secrets of beast guns, granting you the power of their synergistic magic. You gain a 1st-level spell slot. At 6th level, you gain a 2nd-level spell slot and you can select one spell from your repertoire as a signature spell. At 8th level, you gain a 3rd-level spell slot. Each time you gain a spell slot of a new level from this archetype, add a spell of the appropriate spell level to your repertoire, either a common spell of your chosen tradition or another spell of that tradition you’ve learned or discovered." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1e2bce7b-4791-42f3-aabc-585009df4969"), Feats.Instances.BeastGunnerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0ae6b60-6bbb-4cd8-bac6-fc42f2520630"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
