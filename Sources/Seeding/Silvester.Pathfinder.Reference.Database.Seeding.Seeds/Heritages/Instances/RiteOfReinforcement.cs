using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class RiteOfReinforcement : Template
    {
        public static readonly Guid ID = Guid.Parse("b513ad20-14d2-49df-a40a-20a5736532bc");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Rite of Reinforcement"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2f125b48-3875-487b-9635-527fae7111b2"), Type = TextBlockType.Text, Text = "Your woven exoskeleton rivals the hardest armors that can be found. Your exoskeleton is medium armor in the plate armor group that grants a +4 item bonus to AC, a Dex cap of +1, a check penalty of -2, a speed penalty of -5 feet, and a Strength value of 16, and has the comfort trait. You can never wear other armor or remove your exoskeleton. You can etch armor runes onto your exoskeleton as normal." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("fbf0cbeb-92eb-4d4f-8f9b-79726ed23d85"), "Your exoskeleton is medium armor in the plate armor group that grants a +4 item bonus to AC, a Dex cap of +1, a check penalty of -2, a speed penalty of -5 feet, and a Strength value of 16, and has the comfort trait.");
            builder.Manual(Guid.Parse("42e1ff48-fcce-45dd-ab73-5a96e1c72965"), "You can never wear other armor or remove your exoskeleton.");
            builder.Manual(Guid.Parse("bb733a16-10a0-495a-a6f7-56dfd3ab217d"), "You can etch armor runes onto your exoskeleton as normal.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c588454-9e2a-488d-b355-18830988d682"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 107
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Conrasu.ID;
        }
    }
}
