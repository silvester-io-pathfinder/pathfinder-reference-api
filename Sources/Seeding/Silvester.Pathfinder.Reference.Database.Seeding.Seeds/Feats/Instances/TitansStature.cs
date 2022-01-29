using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TitansStature : Template
    {
        public static readonly Guid ID = Guid.Parse("cc9b401f-2225-410c-891d-a1411f72ab95");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Titan's Stature",
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
            yield return new TextBlock { Id = Guid.Parse("84868912-a029-4e7e-9dc0-be1103b13b37"), Type = TextBlockType.Text, Text = $"You grow to even greater size. When using {ToMarkdownLink<Models.Entities.Feat>("Giant's Stature", Feats.Instances.GiantsStature.ID)}, you can instead become Huge (increasing your reach by 10 feet if you were Medium or smaller) while you are raging. You have the clumsy 1 condition as long as you are Huge." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("6f7c112b-adda-44bb-9402-2ee6bfc19a01"), Instincts.Instances.GiantInstinct.ID);
            builder.HaveSpecificFeat(Guid.Parse("cb3a4b21-271a-4139-a844-f3836578b56f"), Feats.Instances.GiantsStature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac84859c-bf6b-477e-b977-54eb40793913"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
