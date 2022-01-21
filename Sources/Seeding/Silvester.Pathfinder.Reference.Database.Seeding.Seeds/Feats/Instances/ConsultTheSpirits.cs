using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConsultTheSpirits : Template
    {
        public static readonly Guid ID = Guid.Parse("132755fc-156a-4bd7-ac49-945912e93dd7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Consult the Spirits",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e6425efe-da3c-4dd8-bbdb-2bd0ee39ee94"), Type = TextBlockType.Text, Text = $"You have learned rites or meditations that enable you to perceive minor, invisible spirits within a place. You reveal the presence of angelic, demonic, or other spirits in service to divine beings, who provide information about sources of powerful positive or negative energy, sacred or profane influences, or the presence of undead." };
            yield return new TextBlock { Id = Guid.Parse("a2414bc3-8b0f-4e06-898c-a585557a54a5"), Type = TextBlockType.Text, Text = $"Spend 10 minutes and attempt a check to {ToMarkdownLink<Models.Entities.SkillAction>("Recall Knowledge", SkillActions.Instances.RecallKnowledge.ID)} with Religion; the DC is determined by the GM (usually a very high DC for the level of the highest-level creature you might encounter in the area). If you're legendary in Religion, you can use this feat once per hour, instead of only once per day, but you can't use it again on any area that overlaps a previous area." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("a8fd6605-53ad-4b84-8967-1d506460b15b"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("6d0c6d6c-95b8-4a86-9ebf-04ea315d13e4"),
                CriticalSuccess = "The spirits reveal themselves to you and have a helpful attitude toward you. Only you can perceive these spirits. They answer three simple questions about the environment within 100 feet of you, depending on the skill you chose and thus the type of spirits you contact. Their answers are almost always a single word, and their knowledge is limited to within their area of interest.",
                Success = "As with a critical success, but the spirits are indifferent to you and answer only one question.",
                Failure = "You are unable to contact the spirits of this place.",
                CriticalFailure = "You contact one or more malevolent spirits. They are hostile toward you, though they may not immediately appear so. They answer up to three questions but give you information that is harmful to you in some way, as determined by the GM.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a2477b0-a5a0-49e2-8d68-02ca8782e33f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
