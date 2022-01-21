using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DodgingRoll : Template
    {
        public static readonly Guid ID = Guid.Parse("336fab1b-1439-4e83-a875-df3b5a2b7559");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dodging Roll",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You take damage from an area effect that allows a Reflex save.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8bbda37c-0872-4072-af11-f1b70096e5a3"), Type = TextBlockType.Text, Text = $"You dodge a blow at the last possible moment. You {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} and gain resistance to all damage equal to your level against the triggering effect. If your {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} moves you out of the triggering effect's area, this resistance is instead equal to your level plus your Dexterity modifier." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("11ec869f-60d8-487d-8179-4149287dc8e0"), Proficiencies.Instances.Master.ID, Skills.Instances.Acrobatics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("abb9cc1e-a914-419a-b01b-33601596c680"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
