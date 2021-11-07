using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElectrifyArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("e2470277-12fe-4a0a-a640-b108ec725182");

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
            yield return new TextBlock { Id = Guid.Parse("8b3b8601-524c-48c4-aaf6-bed49fd993e5"), Type = TextBlockType.Text, Text = "You electrify your armor to punish foes who dare to attack you. For 1 round, any creature that touches you, or that hits you with a melee unarmed attack or a non-reach melee weapon attack, takes 1d4 electricity damage. The effect ends if you cease wearing your armor innovation." };
            yield return new TextBlock { Id = Guid.Parse("2432272d-5806-4ee8-8777-46592bead719"), Type = TextBlockType.Text, Text = "If you have the revolutionary innovation class feature, the damage increases to 2d4." };
            yield return new TextBlock { Id = Guid.Parse("2352fa83-6f56-4b19-b000-8b1d5eb771fb"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("e2f6f3d6-84d6-438f-90dc-61546ea76ec3"), Type = TextBlockType.Text, Text = "~ Unstable Function: You create an unstable chain reaction, sending countless sparks dancing across your armor. Add the (trait: unstable) trait to Electrify Armor. The effects last for 1 minute instead of 1 round, and the damage dice increase from d4s to d12s." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("76028e4b-9a7a-4c5f-9eb2-5e3903e07a39"), Innovations.Instances.Armor.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56b21084-d93c-41d0-8abe-25a5a14419f3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
