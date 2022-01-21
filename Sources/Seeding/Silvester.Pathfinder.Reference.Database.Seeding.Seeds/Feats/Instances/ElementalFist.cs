using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElementalFist : Template
    {
        public static readonly Guid ID = Guid.Parse("ade8aeb8-be9a-42d1-9581-8e67bd14b801");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elemental Fist",
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
            yield return new TextBlock { Id = Guid.Parse("347eb0d9-cf61-4bcd-98b8-2711e2bc243a"), Type = TextBlockType.Text, Text = $"You call upon the power of the elements, infusing your ki with elemental energy and allowing your attacks to deal energy damage. When you cast {ToMarkdownLink<Models.Entities.Spell>("ki strike", Spells.Instances.KiStrike.ID)}, in addition to the damage types normally available, you can deliver the extra damage in the form of a gust of storm-tossed wind (dealing electricity damage and gaining the {ToMarkdownLink<Models.Entities.Trait>("air", Traits.Instances.Air.ID)} trait), a chunk of stone (dealing bludgeoning damage and gaining the {ToMarkdownLink<Models.Entities.Trait>("earth", Traits.Instances.Earth.ID)} trait), a flickering flame (dealing fire damage), or a crashing wave of frigid water (dealing cold damage and gaining the {ToMarkdownLink<Models.Entities.Trait>("water", Traits.Instances.Water.ID)} trait)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b1bed998-58a4-4bfe-8ef1-575e952f46c4"), Feats.Instances.KiStrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8b60342-24e1-49b8-abf1-1fdc19527d74"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
