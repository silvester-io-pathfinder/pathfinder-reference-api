using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CastigatingWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("f700f860-3415-4741-b424-e1b3de4420b8");

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
            yield return new TextBlock { Id = Guid.Parse("e2172138-9669-42fe-9276-f410fb860ff3"), Type = TextBlockType.Text, Text = $"The force of your deity's castigation strengthens your body so you can strike down the wicked. After you damage a fiend using a {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} spell, your weapon or unarmed Strikes deal extra good damage to fiends equal to half the level of the heal spell until the end of your next turn. This is cumulative with any good damage the weapon already deals (such as from a holy rune)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2fc0e4c2-f051-4dd4-92a3-7af24664b92b"), Feats.Instances.HolyCastigation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("88ae7ae7-8258-4aab-9550-4b6d3b32e065"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
