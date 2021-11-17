using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CraftersAppraisal : Template
    {
        public static readonly Guid ID = Guid.Parse("2d8c7021-931e-4d39-880e-ada0ee9d1344");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crafter's Appraisal",
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
            yield return new TextBlock { Id = Guid.Parse("f6600d6d-2cd6-4400-a439-54afc4609afd"), Type = TextBlockType.Text, Text = "Your knowledge of items’ construction allows you to discern their magical effects as well. You can use Crafting instead of a skill associated with a magic tradition to (action: Identify Magic) on magic items, though not on any other sorts of magic." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("9ae0e9c8-3c90-49b4-b641-657e74ee7167"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1805d062-168f-4207-8500-67d0269c4286"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
