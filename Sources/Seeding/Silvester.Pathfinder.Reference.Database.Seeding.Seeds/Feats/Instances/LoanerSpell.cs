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
    public class LoanerSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("25430ddd-c4f7-4063-83ae-84be5643870c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Loaner Spell",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cc2ee095-8292-40f3-9bcb-b8be1f1d1bcd"), Type = TextBlockType.Text, Text = $"During your daily preparations, you can gain the assistance of an allied prepared spellcaster to prepare one spell for the day. The spell can be up to 3rd level. Your ally must be able to prepare and cast it, and the spell must have a Targets entry or an area. Your ally loses a spell slot of the corresponding spell level, and you gain the ability to cast the prepared spell once that day. When you {ToMarkdownLink<Models.Entities.Rule>("Cast the Spell", Rules.Instances.CastASpell.ID)}, use your class DC for any saving throws required by the spell, and your class DC – 10 as a spell attack roll modifier." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("d656f326-51b5-42e3-8d38-6895f6660b04"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("6e405975-9d0a-4657-ad95-cb3a0479b733"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("a0c0496b-e02d-49ec-88ad-726ccd85f282"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("21108081-cd93-4cbb-856c-fdd9ba59e98b"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("a60ed004-5579-4b39-921b-7a457cbfc88f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47686bf6-4397-49a3-acac-a92c042e1364"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
