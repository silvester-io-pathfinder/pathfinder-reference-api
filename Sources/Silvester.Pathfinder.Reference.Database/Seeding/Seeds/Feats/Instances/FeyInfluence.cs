using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FeyInfluence : Template
    {
        public static readonly Guid ID = Guid.Parse("22e3670e-3cea-4144-9bee-9181cd862911");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fey Influence",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2cba223e-b520-4d5b-a7ba-aec102f4cb14"), Type = TextBlockType.Text, Text = "You have been exposed to powerful fey magic. You become trained in primal DCs and spell attack rolls. You gain the (trait: fey) trait and one of the following features which grant an innate primal spell that can be used once per day." };
            yield return new TextBlock { Id = Guid.Parse("f3926727-4091-4e92-9bf0-eb1d0535ee4a"), Type = TextBlockType.Enumeration, Text = " Anteater: You can launch your tongue forward as a deadly attack, gaining (spell: grim tendrils)." };
            yield return new TextBlock { Id = Guid.Parse("b3e12f31-b319-4099-a7da-9ebbaec5a2e1"), Type = TextBlockType.Enumeration, Text = " Dryad: Your body is covered in elegant vines, granting you (spell: summon plant or fungus)." };
            yield return new TextBlock { Id = Guid.Parse("74705c7c-6c49-47da-8bfa-6ae6c0a51a7b"), Type = TextBlockType.Enumeration, Text = " Gremlin: You have long, bat-like ears and gain (spell: bane)." };
            yield return new TextBlock { Id = Guid.Parse("2bc3127e-adbb-49fd-bdf9-926783629d2e"), Type = TextBlockType.Enumeration, Text = " Monarch: You have vestigial, insectile features and gain (spell: spider sting)." };
            yield return new TextBlock { Id = Guid.Parse("bdedec1d-f42d-406f-af17-2bedd2aaa5b7"), Type = TextBlockType.Text, Text = "This feat gains the trait appropriate for your ancestry (human for human, goblin for goblin, etc)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f15fe2a1-e541-4d90-972c-f592f94e5999"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
