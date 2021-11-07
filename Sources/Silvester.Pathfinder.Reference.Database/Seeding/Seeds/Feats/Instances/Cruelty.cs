using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Cruelty : Template
    {
        public static readonly Guid ID = Guid.Parse("d91148d6-ae36-4b4b-b861-1c3c92616c27");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cruelty",
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
            yield return new TextBlock { Id = Guid.Parse("a5ed32c1-7c3f-4e2c-8502-268da46ebf9d"), Type = TextBlockType.Text, Text = "The harm you deal with your corrupting touch saps the strength from your enemy’s body. If your next action is to cast (spell: touch of corruption) on a living creature, the target is also enfeebled 1 for 1 minute if it fails its save (enfeebled 2 if it critically fails)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSpell(Guid.Parse("1f09ad1b-5133-401d-8b93-cc7431913751"), Spells.Instances.TouchOfCorruption.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8eb6dab8-4f1f-411d-8173-9db8418b1d2e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
