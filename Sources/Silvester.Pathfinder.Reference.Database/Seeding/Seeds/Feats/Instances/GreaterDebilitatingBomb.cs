using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreaterDebilitatingBomb : Template
    {
        public static readonly Guid ID = Guid.Parse("950052aa-19ac-48e1-98cd-998656d8cbaa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Debilitating Bomb",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9c0583ae-0a14-4549-9a38-80659ddddfc9"), Type = TextBlockType.Text, Text = "You have learned enhanced techniques and alchemical secrets that allow you to expand the range of effects you can impose with your bombs. When you use (feat: Debilitating Bomb), add the following to the list you can choose from: clumsy 1, enfeebled 1, stupefied 1, or -10-foot status penalty to Speeds." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7536e7e3-e827-4ee7-9543-70dd52cb3bec"), Feats.Instances.DelibitatingBomb.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e28b409-faa1-4fea-a793-a7a2186e94ea"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
