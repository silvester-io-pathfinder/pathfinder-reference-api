using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AthleticStrategist : Template
    {
        public static readonly Guid ID = Guid.Parse("3eb8ce7a-1913-4d82-92d1-37d7b37ca06b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Athletic Strategist",
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
            yield return new TextBlock { Id = Guid.Parse("feb64013-e5f3-4615-82b3-729d6e029ddc"), Type = TextBlockType.Text, Text = $"You know how to calculatedly manipulate joints and body weight. In addition to using {ToMarkdownLink<Models.Entities.Feat>("Devise a Stratagem", Feats.Instances.DeviseAStratagem.ID)} to modify a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, you can use it to modify a {ToMarkdownLink<Models.Entities.SkillAction>("Disarm", SkillActions.Instances.Disarm.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Grapple", SkillActions.Instances.Grapple.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)} attempt, substituting your {ToMarkdownLink<Models.Entities.Feat>("Devise a Stratagem", Feats.Instances.DeviseAStratagem.ID)} roll for the Athletics check. You must apply the substitution to the first eligible attack you make, whether it's a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} or one of the Athletics actions." };
            yield return new TextBlock { Id = Guid.Parse("0e414d70-9f49-4b83-97ec-625c25899a21"), Type = TextBlockType.Text, Text = $"You can also use your Intelligence modifier instead of Strength for the Athletics check when you substitute your {ToMarkdownLink<Models.Entities.Feat>("Devise a Stratagem", Feats.Instances.DeviseAStratagem.ID)} roll, unless you're using a weapon for the maneuver and the weapon doesn't fit the restrictions for using Intelligence with a stratagem." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("74760cb2-b577-47b3-a178-3895fcd0119f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34c34095-d820-4b0d-afb8-06e856c726ea"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
