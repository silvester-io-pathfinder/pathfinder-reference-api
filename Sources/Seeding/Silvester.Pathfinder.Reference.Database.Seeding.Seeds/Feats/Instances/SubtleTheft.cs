using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SubtleTheft : Template
    {
        public static readonly Guid ID = Guid.Parse("7a8379ac-29a2-4e6a-8cce-b6a21c786df0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Subtle Theft",
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
            yield return new TextBlock { Id = Guid.Parse("e8413cbb-1f3a-4fd9-a4f5-a85904ae0072"), Type = TextBlockType.Text, Text = $"When you successfully {ToMarkdownLink<Models.Entities.SkillAction>("Steal", SkillActions.Instances.Steal.ID)} something, observers (creatures other than the creature you stole from) take a -2 circumstance penalty to their Perception DCs to detect your theft. Additionally, if you first {ToMarkdownLink<Models.Entities.SkillAction>("Create a Diversion", SkillActions.Instances.CreateADiversion.ID)} using Deception, taking a single {ToMarkdownLink<Models.Entities.SkillAction>("Palm an Object", SkillActions.Instances.PalmAnObject.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Steal", SkillActions.Instances.Steal.ID)} action doesn't end your undetected condition." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("1e997c4c-8a6b-49b7-94b2-f10a4e6ffb33"), Proficiencies.Instances.Trained.ID, Skills.Instances.Thievery.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f1c6549c-49e3-42c5-a1f2-8ca97489b097"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
