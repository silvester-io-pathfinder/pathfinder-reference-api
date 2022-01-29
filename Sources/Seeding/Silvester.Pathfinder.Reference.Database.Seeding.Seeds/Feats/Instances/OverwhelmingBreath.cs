using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OverwhelmingBreath : Template
    {
        public static readonly Guid ID = Guid.Parse("c3ca46bb-9f26-4fb9-8945-2ce967a73073");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Overwhelming Breath",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5f595364-3ea3-49b3-abca-4d5dd7f09d3a"), Type = TextBlockType.Text, Text = $"You control your breathing and align it with your ki, exhaling with controlled force in order to overcome your opponent's resistance. If you use your next action to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} that has the {ToMarkdownLink<Models.Entities.Trait>("monk", Traits.Instances.Monk.ID)} trait and no duration, the spell and any {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} you make as a result of casting it ignore an amount of the target's resistance to physical damage equal to your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyKiSpells(Guid.Parse("133c5fb1-7533-4975-943e-b5b44d6f5116"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b719d935-f490-4a60-bfd8-e782df858c18"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
