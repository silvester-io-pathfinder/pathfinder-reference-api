using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BackupDisguise : Template
    {
        public static readonly Guid ID = Guid.Parse("2abf77b6-1b72-4cd4-b9cc-6df523d66bbd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Backup Disguise",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("370ac417-364a-4d2e-a3fe-7a8205d32487"), Type = TextBlockType.Text, Text = $"~ Access: member of the Firebrands (second Rank)" };
            yield return new TextBlock { Id = Guid.Parse("25ff560e-f0ed-4921-91a7-23ef473ce19a"), Type = TextBlockType.Text, Text = $"You have a specific disguise that you keep at the ready, worn underneath your outer garment. You can change into this disguise to {ToMarkdownLink<Models.Entities.SkillAction>("Impersonate", SkillActions.Instances.Impersonate.ID)} as a 3-action activity. If you have master proficiency in Deception, it is instead a 2-action activity, and if you have legendary proficiency, it is a single action. You can create a new backup disguise by spending the normal amount of time it takes you to {ToMarkdownLink<Models.Entities.SkillAction>("Impersonate", SkillActions.Instances.Impersonate.ID)}, but you can have only one backup disguise at a time. Having a backup disguise doesn't allow you to remove your armor or any other complex piece of clothing any more quickly, but once you have those off, the disguise is readily available. Because you have the backup disguise at the ready, it's possible that a thorough search might reveal some elements of the disguise (see {ToMarkdownLink<Models.Entities.SkillAction>("Conceal an Object", SkillActions.Instances.ConcealAnObject.ID)} in the Stealth skill)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("4cd3416e-fcef-4cc7-8817-c9b2fc12b986"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("581093c4-eb3b-495d-9502-0c6de73ca5ed"), Traits.Instances.General.ID);
            builder.Add(Guid.Parse("66e5c12b-6f10-4590-8b0a-4c1219c50dfb"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fdc2ecf8-c92c-4441-b529-887f936660cb"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
