using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LessonOfTheElements : Template
    {
        public static readonly Guid ID = Guid.Parse("1f580ba2-dbfa-4c2b-8d1f-494e1dd7e595");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lesson of the Elements",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("db922418-d8ea-4162-87c0-030c4160de5b"), Type = TextBlockType.Text, Text = $"~ Lesson Type: Basic" };
            yield return new TextBlock { Id = Guid.Parse("4d654a24-2fd1-4858-ba42-0804dec98ccb"), Type = TextBlockType.Text, Text = $"You gain the {ToMarkdownLink<Models.Entities.Spell>("elemental betrayal", Spells.Instances.ElementalBetrayal.ID)} hex. Your familiar learns your choice of {ToMarkdownLink<Models.Entities.Spell>("burning hands", Spells.Instances.BurningHands.ID)}, {ToMarkdownLink<Models.Entities.Spell>("air bubble", Spells.Instances.AirBubble.ID)}, {ToMarkdownLink<Models.Entities.Spell>("hydraulic push", Spells.Instances.HydraulicPush.ID)}, or {ToMarkdownLink<Models.Entities.Spell>("pummeling rubble", Spells.Instances.PummelingRubble.ID)}." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6591917-97b2-4532-ac03-9fce3605d0ce"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
