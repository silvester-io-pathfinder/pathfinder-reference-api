using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DispellingSpellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("2c0d2388-9601-41de-9999-4f8a8624726e");

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
            yield return new TextBlock { Id = Guid.Parse("2e6c07aa-285b-4341-9ad2-c82b524c84c3"), Type = TextBlockType.Text, Text = $"The spell you deliver tries to force out magic affecting your enemy. Make a {ToMarkdownLink<Models.Entities.Feat>("Spellstrike", Feats.Instances.Spellstrike.ID)}. If it hits, you also attempt to counteract a single spell (of your choice) active on the target. The counteract level is half your level rounded up, and the counteract check modifier is the standard modifier for counteracting with a spell (your Intelligence modifier plus your spellcasting proficiency bonus, plus any bonuses or penalties that specifically apply to counteract checks)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ac04a4ff-6af5-455f-a29f-d00ea9e0f505"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("11efc57e-125c-4517-88a5-d3efb5f93c7e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
