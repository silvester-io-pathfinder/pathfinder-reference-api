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
    public class DisarmingAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("ffcbfcd9-e908-46f7-a4f3-fc471e4b98fd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Disarming Assault",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fd771e27-1081-48df-ab6a-889c8ddb6a99"), Type = TextBlockType.Text, Text = $"You attack with enough force to knock the weapon out of your foe's hands. Make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}; if you hit, you can attempt an Athletics check to {ToMarkdownLink<Models.Entities.SkillAction>("Disarm", SkillActions.Instances.Disarm.ID)} that foe." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("71496510-e884-44cd-a640-0fb2c0be6db5"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Flourish.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Rage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b739b1a-269a-46d0-8196-2bd19b4df879"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
