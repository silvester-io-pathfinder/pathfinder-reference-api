using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DandyDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("4d53107d-533d-4de1-bf1d-cae5370df5b3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dandy Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the dandy archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d758b108-210f-4bd7-b214-8f71e51e8348"), Type = TextBlockType.Text, Text = "You are a consummate student of dignity, etiquette, and fashion. You can use the Diplomacy skill to perform the special downtime activity, (feat: Influence Rumor)." };
            yield return new TextBlock { Id = Guid.Parse("2983646f-9762-4275-8769-74e7bd1f85eb"), Type = TextBlockType.Text, Text = "You become trained in Deception and Society; if you were already trained, you become an expert instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("2746a5a0-e42d-4f33-8b4b-62031759583d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("abed999c-5bcc-4420-a4f3-92c4854be894"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
