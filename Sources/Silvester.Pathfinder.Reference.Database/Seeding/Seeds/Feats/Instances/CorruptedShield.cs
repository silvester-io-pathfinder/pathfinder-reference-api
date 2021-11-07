using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CorruptedShield : Template
    {
        public static readonly Guid ID = Guid.Parse("8258fc6f-88bf-4e92-a50a-af399d975340");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Corrupted Shield",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("92993649-23cb-44b1-94a0-d047e615a93c"), Type = TextBlockType.Text, Text = "Your shield ally is more than just a spirit of protection— it’s a conduit for deadly divine magic. When you use your shield ally to (feat: Shield Block) a melee unarmed attack or a melee weapon (action: Strike) from an adjacent creature, the attacker takes 1d6 evil or negative damage (your choice). If the attack or (action: Strike) breaks or destroys your shield, double this additional damage." };
            yield return new TextBlock { Id = Guid.Parse("b32e0d39-6fa9-4604-bd40-0c8943602088"), Type = TextBlockType.Text, Text = "The damage the attacker takes increases to 2d6 at 11th level and 3d6 at 16th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("b8efd404-8680-4624-a186-276dc05085bf"), DivineAllies.Instances.Shield.ID);
            builder.HaveSpecificTenet(Guid.Parse("9ff56a73-642f-40d8-a12f-d5d1f3857fcb"), Tenets.Instances.Evil.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("015a453e-a395-4ad5-a60c-37b8ee2f3a78"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
