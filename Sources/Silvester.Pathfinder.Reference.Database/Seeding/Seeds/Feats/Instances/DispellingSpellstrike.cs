using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DispellingSpellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("0ba68bf5-1304-4a85-bb2d-b8a7c621c5a4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dispelling Spellstrike",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4d32ad75-650b-465c-b5c0-d634faf87824"), Type = TextBlockType.Text, Text = "The spell you deliver tries to force out magic affecting your enemy. Make a (feat: Spellstrike). If it hits, you also attempt to counteract a single spell (of your choice) active on the target. The counteract level is half your level rounded up, and the counteract check modifier is the standard modifier for counteracting with a spell (your Intelligence modifier plus your spellcasting proficiency bonus, plus any bonuses or penalties that specifically apply to counteract checks)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("85446afa-ff66-4d15-932d-9184444c2389"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("592bd814-a6f4-455d-b0cd-bfc351fd0b0a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
