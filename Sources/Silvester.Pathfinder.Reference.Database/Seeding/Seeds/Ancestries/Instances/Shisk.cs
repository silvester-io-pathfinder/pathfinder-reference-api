using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances
{
    public class Shisk : Template
    {
        public static readonly Guid ID = Guid.Parse("75e6a848-2fd0-49df-8701-0c3b57cc5c65");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Shisk", 
                BaseHealth = 8, 
                RarityId = Rarities.Instances.Rare.ID, 
                SampleNames = "Adomssha, Asjossa, Chishinsa, Dalissho, Lessia, Lishassha, Somissu, Quinshu"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("d4b273ef-c5ca-4bb4-a0ff-bed1b3370d13"), Type = TextBlockType.Text, Text = "Shisks are secretive mountain-dwellers, bone-feathered humanoids who lurk underground in dark tunnels and caverns. Their fascination with collecting and protecting esoteric knowledge is one of the few things that can persuade them to explore the outside world." };
            yield return new TextBlock { Id = Guid.Parse("11666d05-6c71-4771-aa19-24b55a1a741e"), Type = TextBlockType.Text, Text = "Shisks rarely encounter other peoples, even in the Mwangi Expanse. Shisks subsist on low-calorie diets of vegetables and insects, causing them to rarely compete with others for resources or seek out people to trade. They have a tight-knit society, wary of outsiders, though they don't outright attack visitors." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Their history is passed down verbally and musically, and they rarely maintain written records in order to keep their knowledge safe. Often the only proof that shisks exist comes from explorers finding signs of their architecture: organic and low-impact adobe buildings carved out of mountains rather than built atop them." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("e6902958-c980-4d14-8029-d7af9be9a3e3"), Type = TextBlockType.Enumeration, Text = "See yourself as a part of nature and avoid taking anything you don't need." };
            yield return new TextBlock { Id = Guid.Parse("722419c1-6986-4218-b9f3-58b4b22098ff"), Type = TextBlockType.Enumeration, Text = "Be wary of others getting one over on you by tricking you into revealing something." };
            yield return new TextBlock { Id = Guid.Parse("55b3031f-6a70-4fe1-bf3e-3384b246a685"), Type = TextBlockType.Enumeration, Text = "Love warmth and enjoy sunbathing despite your subterranean nature." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("180809c4-3c69-4f06-84e1-a7a1ac11ece6"), Type = TextBlockType.Enumeration, Text = "Are concerned by your diet and how little you eat." };
            yield return new TextBlock { Id = Guid.Parse("550e666b-2e0c-40b7-8896-3d74a4f9bb2a"), Type = TextBlockType.Enumeration, Text = "Become confused or annoyed by your refusal to give information freely." };
            yield return new TextBlock { Id = Guid.Parse("8c893b2d-fab6-4272-9fb6-ddb8fd0c6288"), Type = TextBlockType.Enumeration, Text = "Appreciate your incredible memory and knowledge." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("f59b15b7-6a78-4fc2-b1d0-aaea68f4bd26"), Type = TextBlockType.Text, Text = "Shisks have features and skin-tones similar to humans, usually ranging from deep tan to deep black. They are lighter than their body size might indicate, due to having hollow bones. Shisks have no body hair—instead, their backs are covered in vestigial plumage that now grow only as bony quills that resemble calcified pin feathers. Though shisks can't fly, these spines are longer around their arms, as if they once had wings. A shisk's eyes contract into slits in the sunlight and are typically warmly colored, from hazel and brown to more unique colors like red or amber. Shisks have two prominent narrow fangs as the front teeth on their upper jaw, causing some people to mistake them forasanbosamsorvampires." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("5f5825a6-91c3-4d2d-90b1-fe191b937d6f"), Type = TextBlockType.Text, Text = "Though rarely encountered, shisks are willing to speak, host, and trade with outsiders. Their economy might be confusing to others: they greatly eschew materialism in favor of information and the arts. They freely give away material goods for knowledge or even performances, considering themselves on the “winning” side of a bargain if people are willing to take material things in exchange for valuable information. They never give away information for material goods, only for other knowledge, and they rarely ask for material goods in trades." };
            yield return new TextBlock { Id = Guid.Parse("7749dfca-9efc-4793-a820-a66e7c65fd02"), Type = TextBlockType.Text, Text = "Shisk are so paranoid that different communities of shisks have been known to clash with one another over secrets. Wars are fought not over territory or resources, but over coveted information. On a few occasions, when shisk sages or diplomats convinced different groups of shisks to put aside their differences and collaborate, great puzzles and mysteries of Golarion have been solved in a matter of hours." };
            yield return new TextBlock { Id = Guid.Parse("151a1fc5-27a0-4a75-89b8-04ae71c4e24c"), Type = TextBlockType.Text, Text = "Shisk clothing is loose and breathable, and often minimal to avoid catching on their bony feathers. Due to their society's disregard for materialism, the shisk live in great harmony with nature around them, taking only what they need. Shisk often take up simple hobbies, such as sunbathing." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("ee6831f9-624f-4ac7-962c-14d049259ddb"), Type = TextBlockType.Text, Text = "Seeing themselves as part of the natural world and typically focused on their own pursuits instead of society, most shisks adopt neutral alignments. Some shisks are patrons of gods that have been long forgotten. Many shisks worship the sun godChohar, a fact which might seem odd for people who dwell underground. TheGreen Faithis highly common among shisks, but when seeking out personal gods to revere, most shisks prefer gods of knowledge and secrets such asIrez,Nethys, orNorgorber." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("d7ecc8ae-7261-4d25-a149-511eb39c9bdf"), Type = TextBlockType.Text, Text = "With a cultural obsession around learning and secrets, shisks are perfect fits for thescholarbackground. They are also reclusive in their tasks, makinghermitsandnomadscommon. Their love of histories spread through song makes them idealentertainers, while shisks' coexistence with nature means they are idealherbalistsandanimal whisperers. Shisks make excellentbardsandwizards, as they excel at focus and long hours of research. Those who venture into other societies to learn are also great fits for theinvestigatorclass." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("6a14877e-0b4f-4c39-9566-9e37ef0046bf"), Type = TextBlockType.Text, Text = "Shisk names are usually granted by their parents, though these names often have secret meanings known only to their families. They are often filled with sibilant syllables, occasionally punctuated by sharp vowels." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield break;
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Humanoid.ID;
            yield return Traits.Instances.Shisk.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("57f9337d-bdc3-4e33-959f-22943e987122"), ModifierType.Add, modifier: 8);
            builder.ModifySpecificSpeed(Guid.Parse("b1d98944-5472-48d7-8281-edcc4a03aa08"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("b3878923-8d4d-46c4-8797-df516bf941cd"), Stats.Instances.Intelligence.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("b241842a-cff4-4992-bc64-69f674d0e1d7"));
            builder.GainSpecificLanguage(Guid.Parse("6c964eca-14f9-49fa-bc26-d278f8a0e592"), Languages.Instances.Mwangi.ID);
            builder.GainSpecificLanguage(Guid.Parse("f65e8a80-c1bf-41ec-a06d-9ad3084db598"), Languages.Instances.Shisk.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse(""), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("93493296-ba43-4f80-a6de-9b6c8f8185a6"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 123
            };
        }
    }
}
