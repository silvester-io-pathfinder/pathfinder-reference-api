using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnderworldInvestigator : Template
    {
        public static readonly Guid ID = Guid.Parse("1020f8ca-1ee9-42bd-bd6f-25dd9c62d7b6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Underworld Investigator",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e26a16f3-1e7d-4ea7-879f-981b60f70b14"), Type = TextBlockType.Text, Text = $"Your work as an investigator makes you familiar with the criminal element. You might be a criminal yourself, or you might have gained an understanding of how they operate from the outside. You become trained in Underworld Lore, and you gain your {ToMarkdownLink<Models.Entities.Feat>("Pursue a Lead", Feats.Instances.PursueALead.ID)} circumstance bonus to Thievery checks to investigate the subject of your lead (such as checks to {ToMarkdownLink<Models.Entities.SkillAction>("Steal", SkillActions.Instances.Steal.ID)} a clue from a suspect or {ToMarkdownLink<Models.Entities.SkillAction>("Pick a Lock", SkillActions.Instances.PickALock.ID)} to open a safe with damning documents)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9cd3bdd-a36b-49b6-8ac7-050fc16d9dfd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
