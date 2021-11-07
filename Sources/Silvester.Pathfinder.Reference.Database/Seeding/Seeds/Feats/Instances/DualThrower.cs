using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DualThrower : Template
    {
        public static readonly Guid ID = Guid.Parse("c86a157e-5c1d-461f-bc2b-4e8fa54b5da6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dual Thrower",
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
            yield return new TextBlock { Id = Guid.Parse("e2727d1a-3782-476c-9b87-9a10fa304935"), Type = TextBlockType.Text, Text = "You know how to throw two weapons as easily as strike with them. Whenever a dual-weapon warrior feat allows you to make a melee (action: Strike), you can instead make a ranged (action: Strike) with a (trait: thrown) weapon or a one-handed ranged weapon you are wielding. Any effects from these feats that apply to one-handed melee weapons or melee (action: Strikes | Strike) also apply to one-handed ranged weapons and ranged (action: Strikes | Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("510ac915-4411-4161-a341-82f02fce0220"), Feats.Instances.DualWeaponWarriorDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4eab2e47-d63e-496e-b02a-dca376410b7b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
