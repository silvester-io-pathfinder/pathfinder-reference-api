using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrueDebilitatingBomb : Template
    {
        public static readonly Guid ID = Guid.Parse("957ea482-11fd-44c9-9a93-32960639ff4d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "True Debilitating Bomb",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fbbb2c0c-a1da-41db-8ac3-0d416198abe4"), Type = TextBlockType.Text, Text = "Ever inventive, you have discovered increasingly devastating ways for your bombs to impede and hamper your foes. When you use (feat: Debilitating Bomb), add the following to the list of effects you can choose from: enfeebled 2, stupefied 2, or a -15-foot status penalty to Speeds. If you instead apply one of the effects listed in (feat: Debilitating Bomb), the target avoids the effect only if the result of its saving throw is a critical success." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("be722e26-72db-4eee-a18e-9181eb51bd9d"), Feats.Instances.GreaterDebilitatingBomb.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("688104c9-6895-414e-a748-6c0d88e83dd7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
