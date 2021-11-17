using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElectrifyArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("48b6a506-9ffb-432e-8acc-fc398aec5fe2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Electrify Armor",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f25a6f37-7f86-44f5-bafa-382eaa280d0a"), Type = TextBlockType.Text, Text = "You electrify your armor to punish foes who dare to attack you. For 1 round, any creature that touches you, or that hits you with a melee unarmed attack or a non-reach melee weapon attack, takes 1d4 electricity damage. The effect ends if you cease wearing your armor innovation." };
            yield return new TextBlock { Id = Guid.Parse("53a2e4e3-761a-4c99-8ed9-e44fca381230"), Type = TextBlockType.Text, Text = "If you have the revolutionary innovation class feature, the damage increases to 2d4." };
            yield return new TextBlock { Id = Guid.Parse("3793c92c-e166-4612-9a26-0e610cc0adf2"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("356080ae-b2a8-47a9-b842-14f65130ecd9"), Type = TextBlockType.Text, Text = "~ Unstable Function: You create an unstable chain reaction, sending countless sparks dancing across your armor. Add the (trait: unstable) trait to Electrify Armor. The effects last for 1 minute instead of 1 round, and the damage dice increase from d4s to d12s." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("b9409bc5-9417-42f1-bd3d-b29704fc5832"), Innovations.Instances.Armor.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c6fe00b-0c8f-4367-84fc-ec2aa54df4d9"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
