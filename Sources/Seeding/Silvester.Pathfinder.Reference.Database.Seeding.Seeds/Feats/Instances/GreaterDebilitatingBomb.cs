using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreaterDebilitatingBomb : Template
    {
        public static readonly Guid ID = Guid.Parse("fbec4131-11f7-4c26-9a2c-4b7c196abdf9");

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
            yield return new TextBlock { Id = Guid.Parse("67eff699-1292-48aa-9a09-a3320cf7f3f8"), Type = TextBlockType.Text, Text = $"You have learned enhanced techniques and alchemical secrets that allow you to expand the range of effects you can impose with your bombs. When you use {ToMarkdownLink<Models.Entities.Feat>("Debilitating Bomb", Feats.Instances.DebilitatingBomb.ID)}, add the following to the list you can choose from: clumsy 1, enfeebled 1, stupefied 1, or -10-foot status penalty to Speeds." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0e0955ab-56d4-41e6-9152-1beed630245e"), Feats.Instances.DebilitatingBomb.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3384abd3-a4ce-4b6f-9155-475b8408a9d0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
