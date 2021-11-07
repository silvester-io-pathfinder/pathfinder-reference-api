using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MeditativeFocus : Template
    {
        public static readonly Guid ID = Guid.Parse("ff12ce74-8dd4-4523-ab9f-d9aaa395d894");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Meditative Focus",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("22a1c2cb-3735-40bc-856f-6f68541cde03"), Type = TextBlockType.Text, Text = "Your meditation is so effective that you can achieve a deep focus. If you have spent at least 2 Focus Points since the last time you (action: Refocused | Refocus), you recover 2 Focus Points when you (action: Refocus) instead of 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyKiSpells(Guid.Parse("44287792-52a1-4b42-860b-8e7a2e298e9a"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aedb63c4-4a61-4551-b356-290df4dceb69"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
