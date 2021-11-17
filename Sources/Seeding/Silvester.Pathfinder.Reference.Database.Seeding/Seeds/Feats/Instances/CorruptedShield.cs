using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CorruptedShield : Template
    {
        public static readonly Guid ID = Guid.Parse("8be34b3e-de6d-4a64-b8d4-64ca11045a6c");

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
            yield return new TextBlock { Id = Guid.Parse("4d7d4f7e-a19b-4e3f-8bee-1ac179c7a60b"), Type = TextBlockType.Text, Text = "Your shield ally is more than just a spirit of protection— it’s a conduit for deadly divine magic. When you use your shield ally to (feat: Shield Block) a melee unarmed attack or a melee weapon (action: Strike) from an adjacent creature, the attacker takes 1d6 evil or negative damage (your choice). If the attack or (action: Strike) breaks or destroys your shield, double this additional damage." };
            yield return new TextBlock { Id = Guid.Parse("16c90dca-5029-4893-9961-b7f9673581dc"), Type = TextBlockType.Text, Text = "The damage the attacker takes increases to 2d6 at 11th level and 3d6 at 16th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("fe5ae896-3d4e-47a9-b23e-c45f4f6c327c"), DivineAllies.Instances.Shield.ID);
            builder.HaveSpecificTenet(Guid.Parse("07d6916b-1a48-43d0-ba6a-cb1a216c235d"), Tenets.Instances.Evil.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("301d66e7-5fb0-4c3e-95b4-7729480b627d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
