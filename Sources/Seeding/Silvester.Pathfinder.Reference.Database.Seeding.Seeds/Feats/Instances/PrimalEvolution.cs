using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PrimalEvolution : Template
    {
        public static readonly Guid ID = Guid.Parse("92afa25a-8697-41df-a816-5e8808c91a23");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Primal Evolution",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b321801f-078d-4d19-b4e2-07ec25846285"), Type = TextBlockType.Text, Text = "You can call upon the creatures of the wild for aid. You gain an additional spell slot of your highest level, which you can use only to cast (spell: summon animal) or (spell: summon plants or fungi | summon plant or fungus). You can cast either of these spells using that spell slot, even if it they aren't in your spell repertoire." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificBloodlineTradition(Guid.Parse("b06e46ab-271b-4fb9-8410-be8f48139fe2"), MagicTraditions.Instances.Primal.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc2a48a9-d0c5-492c-97bb-08165a784209"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
