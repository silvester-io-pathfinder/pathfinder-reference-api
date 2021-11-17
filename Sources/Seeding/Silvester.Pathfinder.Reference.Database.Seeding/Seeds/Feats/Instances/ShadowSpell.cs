using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShadowSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("7e4a7d33-069f-4d61-bf54-5dbc557ee661");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shadow Spell",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2c66ef99-c313-47f8-8256-4a3cda498f28"), Type = TextBlockType.Text, Text = "You attach a piece of your shadow to a spell to cloud the senses and cause mischief. If the next action you take is to (action: Cast a Spell) that has the (trait: shadow) trait, choose one creature affected by the spell. This creature either gains a +2 status bonus to Stealth or takes a –2 status penalty to Perception (your choice). This lasts for 1 round. This choice and the effect occur after resolving any checks for the spell’s initial effects. If the chosen creature is your enemy, it’s affected only if your spell attack roll succeeded or if it failed its saving throw." };
            yield return new TextBlock { Id = Guid.Parse("63d88545-377d-4172-8c60-45a9b30d9166"), Type = TextBlockType.Text, Text = "The effects of Shadow Spell end if you use Shadow Spell again." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5652fe16-893b-4b37-91aa-ac121d6992bd"), Feats.Instances.ShadowdancerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("573a758f-561f-4712-82c3-b7820c979865"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
