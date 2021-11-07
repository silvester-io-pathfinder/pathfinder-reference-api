using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BellflowerTillerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("2812bfa0-299e-4b06-9850-d832cfa34507");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bellflower Tiller Dedication",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the Bellflower tiller archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a57bd094-2595-438f-921d-7647b7ebcac7"), Type = TextBlockType.Text, Text = "You dedicate yourself to freeing slaves and escorting them to freedom. You gain a +5-foot status bonus to your Speed." };
            yield return new TextBlock { Id = Guid.Parse("1ca0ac44-c4d4-4baf-bedc-019b502b57cc"), Type = TextBlockType.Text, Text = "Choose up to six other people to be your “crop.” Members of your crop can use your Speed for overland travel if it’s higher than their own. Members more than 60 feet from you lose all benefits (from this or other Bellflower tiller feats) of being part of your crop, but they regain those benefits immediately when they return. You can add or remove someone from your crop by spending 10 minutes in conversation with them." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("2106bed0-c351-4bf2-b231-1d214e23ada4"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("dd518964-80fb-49d0-8745-c5333cc6fdf7"), Proficiencies.Instances.Expert.ID, Skills.Instances.Stealth.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("5cc41069-49fc-49f9-be7a-c1496ffd6fec"), Proficiencies.Instances.Expert.ID, Skills.Instances.Survival.ID);
            builder.Manual(Guid.Parse("910ca8d9-796b-4329-88a6-b11f3106d078"), "Member of the Bellflower Network");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("762e4a89-cce8-4a66-bb1d-e3ca2fedc05a"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
