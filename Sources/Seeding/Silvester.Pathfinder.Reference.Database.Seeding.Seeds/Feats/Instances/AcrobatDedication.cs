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
    public class AcrobatDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("d498ffea-1c31-4507-8a14-2fd951261992");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Acrobat Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the acrobat archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3791fb58-435b-4564-bff7-659b78701ba9"), Type = TextBlockType.Text, Text = $"You become an expert in Acrobatics. At 7th level, you become a master in Acrobatics, and at 15th level, you become legendary in Acrobatics. Whenever you critically succeed at an Acrobatics check to {ToMarkdownLink<Models.Entities.SkillAction>("Tumble Through", SkillActions.Instances.TumbleThrough.ID)} an enemy's space, you don't treat the enemy's space as difficult terrain." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("1685e97d-0587-4f7b-aeed-2944c8d10227"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c59fddb1-e4c8-4610-b789-7fa7395d86d1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
