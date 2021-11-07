using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElementalFist : Template
    {
        public static readonly Guid ID = Guid.Parse("e8be4987-1868-4205-bdea-cc2364dabd27");

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
            yield return new TextBlock { Id = Guid.Parse("98b12cc3-42ef-4238-bf92-2870f69d02cd"), Type = TextBlockType.Text, Text = "You call upon the power of the elements, infusing your ki with elemental energy and allowing your attacks to deal energy damage. When you cast (spell: ki strike), in addition to the damage types normally available, you can deliver the extra damage in the form of a gust of storm-tossed wind (dealing electricity damage and gaining the (trait: air) trait), a chunk of stone (dealing bludgeoning damage and gaining the (trait: earth) trait), a flickering flame (dealing fire damage), or a crashing wave of frigid water (dealing cold damage and gaining the (trait: water) trait)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("63ee800b-707e-4ce3-9811-dc8cadc60a97"), Feats.Instances.KiStrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21a852cc-5083-49aa-a78b-047dd899064c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
