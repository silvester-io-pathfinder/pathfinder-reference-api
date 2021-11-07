using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShieldOfReckoning : Template
    {
        public static readonly Guid ID = Guid.Parse("935e2146-35b3-4648-a33c-6cf6e8242239");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shield of Reckoning",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A foe's attack against an ally matches the trigger for both your Shield Block reaction and your champion's reaction.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c1c945a8-936f-4588-be51-7498659714fa"), Type = TextBlockType.Text, Text = "When you shield your ally against an attack, you call upon your power to protect your ally further. You use the (feat: Shield Block) reaction to prevent damage to an ally and also use your champion’s reaction against the foe that attacked your ally." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8e92f445-685a-4afb-a32e-3198e7411620"), Feats.Instances.ChampionsReaction.ID);
            builder.HaveSpecificDivineAlly(Guid.Parse("150f9568-301d-4c86-aba9-7f949f493cba"), DivineAllies.Instances.Shield.ID);
            builder.HaveSpecificTenet(Guid.Parse("13ca09ca-d02f-4f62-9892-3ecf76ef9e25"), Tenets.Instances.Good.ID);
            builder.HaveSpecificFeat(Guid.Parse("0ae92702-a6d3-4ae0-9478-dbaba771ad53"), Feats.Instances.ShieldWarden.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("02d6d4cc-a439-4f00-a208-8e6de5cabe83"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
