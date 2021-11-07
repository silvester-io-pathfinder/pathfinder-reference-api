using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CastigatingWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("7188af7d-8b22-46a1-bdfb-87eb9e0b5481");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Castigating Weapon",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dbc3ddf6-092f-4421-8412-f6e5cb52d3a1"), Type = TextBlockType.Text, Text = "The force of your deity’s castigation strengthens your body so you can strike down the wicked. After you damage a fiend using a (spell: heal) spell, your weapon or unarmed Strikes deal extra good damage to fiends equal to half the level of the heal spell until the end of your next turn. This is cumulative with any good damage the weapon already deals (such as from a holy rune)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4756ed3c-6026-45ee-a87c-0521ef545144"), Feats.Instances.HolyCastigation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f33fe4b4-963b-4698-8ed4-88662d6742eb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
