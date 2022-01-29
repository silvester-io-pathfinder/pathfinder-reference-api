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
    public class ExpertSorcererSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("022aa7a8-4621-4b7a-85d8-ab1a94dd42e5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Sorcerer Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("c2060ebf-1cc1-450f-99ae-9255c8730502"), Type = TextBlockType.Text, Text = $"Your proficiency ranks for your bloodline's spell attack rolls and spell DCs increase to expert, and you gain a 4th-level spell slot. You can select a second spell from your repertoire as a signature spell. At 14th level, you gain a 5th-level spell slot, and at 16th level, you gain a 6th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b2e8957f-61c7-496d-9e3a-fb001cdfc4b3"), Feats.Instances.BasicSorcererSpellcasting.ID);
            builder.AddOr(Guid.Parse("17d5ca77-882d-4866-9b74-49d5996a98ce"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("ac8a1bce-539d-425a-af1e-d34896e329a0"), Proficiencies.Instances.Master.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("578a2ce2-dd17-4547-a4d9-998316e643df"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("17f85303-c438-4088-a1cb-d408cb24761b"), Proficiencies.Instances.Master.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("c2820f3c-36e0-4390-9e10-2798a3d3c2d4"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
            });
            //TODO: Add prerequisites.
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cfe67cb1-dd4b-4b67-a048-c0b54b8bc636"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
