using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcaneSight : Template
    {
        public static readonly Guid ID = Guid.Parse("a6a73254-243b-467a-a906-b1ad2c211803");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Sight",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2e2447f0-239b-4d10-89da-f660f37ba241"), Type = TextBlockType.Text, Text = "You’ve trained yourself to constantly be on the lookout for magical effects, even when focusing on looking out for other things. When you are (activity: Searching | Search), you also gain the benefits of (spell: Detect Magic) unless you choose not to." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSpell(Guid.Parse("ad1568c5-9fad-4567-a563-30012f81d37c"), Spells.Instances.DetectMagic.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac4f7e17-2080-4255-b741-c64bceaea22e"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
