using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BasicWitchSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("a6b692da-81e5-4c2c-a9b5-e5877d15f022");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Basic Witch Spellcasting",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bed0275b-cfe9-4a5d-a502-89f086d5880c"), Type = TextBlockType.Text, Text = "You gain a 1st-level spell slot. At 6th level, you gain a 2nd-level spell slot. At 8th level, you gain a 3rd-level spell slot. Each time you gain a spell slot of a new level from the witch archetype, add two common spells of that level to your familiar." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1e353aa0-f2d3-4025-ac12-5844ed86a08d"), Feats.Instances.WitchDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("364bc014-757e-4ea6-a017-4440e741cb38"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
