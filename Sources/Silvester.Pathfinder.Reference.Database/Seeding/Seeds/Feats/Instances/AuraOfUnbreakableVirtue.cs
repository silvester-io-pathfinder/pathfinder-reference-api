using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AuraOfUnbreakableVirtue : Template
    {
        public static readonly Guid ID = Guid.Parse("0bcd332f-f3b8-4c70-98eb-944b369abcd1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aura of Unbreakable Virtue",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b1fa6a59-9d44-4809-9b36-855a31577cb6"), Type = TextBlockType.Text, Text = "~ Access: secure Visitor’s Pins or an alliance with Mengkare." };
            yield return new TextBlock { Id = Guid.Parse("d7837722-bb83-4fbf-808f-dc5da9486cf8"), Type = TextBlockType.Text, Text = "You are a paragon of all that is good, your overwhelming aura causing evildoers to cower. All evil creatures within 15 feet of you take a -1 status penalty to checks and DCs that target you or your allies. This penalty is -2 against creatures you have taken an oath against (such as dragons if you have the (feat: Dragonslayer Oath) feat). You can choose to suppress or resume this aura as an action, which has the (trait: concentrate) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("d17d8837-513e-4658-8dd4-3b70b13f0382"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("96116964-c5f8-4ce7-850a-11d0608df0d2"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
