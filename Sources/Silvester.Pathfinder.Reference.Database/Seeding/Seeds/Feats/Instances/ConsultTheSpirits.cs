using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConsultTheSpirits : Template
    {
        public static readonly Guid ID = Guid.Parse("f61814cb-dd39-4c71-adfd-ab8694bf6ce1");

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
            yield return new TextBlock { Id = Guid.Parse("d944021a-9691-4e84-8cbb-faff83ddf255"), Type = TextBlockType.Text, Text = "You have learned rites or meditations that enable you to perceive minor, invisible spirits within a place. You reveal the presence of angelic, demonic, or other spirits in service to divine beings, who provide information about sources of powerful positive or negative energy, sacred or profane influences, or the presence of undead." };
            yield return new TextBlock { Id = Guid.Parse("4af054b4-6347-4dd6-a83f-3bd0d7d5f51c"), Type = TextBlockType.Text, Text = "Spend 10 minutes and attempt a check to (action: Recall Knowledge | Recall Knowledge - Religion) with Religion; the DC is determined by the GM (usually a very high DC for the level of the highest-level creature you might encounter in the area). If you’re legendary in Religion, you can use this feat once per hour, instead of only once per day, but you can’t use it again on any area that overlaps a previous area." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("1fd0afbf-9fd9-4609-9a0a-45a92743c1a7"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("d7f17844-d964-4cba-b523-9dc2556336a9"),
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
                Id = Guid.Parse("d2fd473a-de3c-4963-a96d-57022ae9fdb1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
