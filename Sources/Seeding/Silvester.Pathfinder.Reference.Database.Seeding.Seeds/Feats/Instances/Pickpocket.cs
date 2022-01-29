using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Pickpocket : Template
    {
        public static readonly Guid ID = Guid.Parse("2be08774-6845-4993-a5a7-6340415858dc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pickpocket",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8908d0c7-3470-4cfd-aa2b-bd2d74728f78"), Type = TextBlockType.Text, Text = $"You can {ToMarkdownLink<Models.Entities.SkillAction>("Steal", SkillActions.Instances.Steal.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Palm an Object", SkillActions.Instances.PalmAnObject.ID)} that's closely guarded, such as in a pocket, without taking the -5 penalty. You can't steal objects that would be extremely noticeable or time consuming to remove (like worn shoes or armor or actively wielded objects). If you're a master in Thievery, you can attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Steal", SkillActions.Instances.Steal.ID)} from a creature in combat or otherwise on guard. When doing so, {ToMarkdownLink<Models.Entities.SkillAction>("Stealing", SkillActions.Instances.Steal.ID)} requires 2 manipulate actions instead of 1, and you take a -5 penalty." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("5c59f759-c1d6-4627-b36e-dd6c4e83e32a"), Proficiencies.Instances.Trained.ID, Skills.Instances.Thievery.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("278484da-72c5-4960-938a-91d1ada4a6fb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
